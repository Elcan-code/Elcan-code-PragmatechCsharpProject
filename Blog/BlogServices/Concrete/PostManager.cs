using System.Collections.Generic;
using System.Threading.Tasks;
using BlogData.Abstract;
using BlogEntities.Concrete;
using BlogEntities.Dtos;
using BlogServices.Abstract;
using BlogShared.Utilities.Results.Abstract;
using BlogShared.Utilities.Results.ComplexTypes;
using BlogShared.Utilities.Results.Concrete;
namespace BlogServices.Concrete
{
    public class PostManager : IPostService
    {
        #region fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region ctor
        public PostManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region methods

        public async Task<IDataResult<PostDto>> GetAsync(int id)
        {
            var entity = await _unitOfWork.Posts.GetAsync(i => i.Id == id, c => c.Comments);

            if (entity != null)
            {
                var dto = new PostDto()
                {
                    Entity = entity,
                    ResultStatus = ResultStatus.Success
                };
                return new DataResult<PostDto>(resultStatus: ResultStatus.Success, dto);
            }
            return new DataResult<PostDto>(resultStatus: ResultStatus.Error, null, "not found");
        }

        public async Task<IDataResult<PostListDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.Posts.GetAllAsync(null, c => c.Comments);

            if (entities.Count > -1)
            {
                var dto = new PostListDto()
                {
                    Entities = entities,
                    ResultStatus = ResultStatus.Success
                };
                return new DataResult<PostListDto>(ResultStatus.Success, dto);
            }

            return new DataResult<PostListDto>(ResultStatus.Error, null, "not found");
        }

        public async Task<IDataResult<PostListDto>> GetAllByNonDeletedAsync()
        {
            var entities = await _unitOfWork.Posts.GetAllAsync(c => !c.IsDeleted, c => c.Comments);
            if (entities.Count > -1)
            {
                var dto = new PostListDto()
                {
                    Entities = entities,
                    ResultStatus = ResultStatus.Success
                };
                return new DataResult<PostListDto>(ResultStatus.Success, dto);
            }

            return new DataResult<PostListDto>(ResultStatus.Error, null, "not found");
        }

        public async Task<IResult> AddAsync(PostAddDto dto, string createdByName)
        {
            var entity = new Post(dto.CategoryId, dto.Content, dto.Date, dto.Note, dto.SeoAuthor, dto.SeoDescription, dto.SeoTags, dto.Thumbnail, dto.Title, dto.UserId);
            entity.SetIsActive(dto.IsActive);
            entity.SetCreatedByName(createdByName);

            await _unitOfWork.Posts.AddAsync(entity);

            var result = await _unitOfWork.SaveChangesAsync();

            if (result > 0)
            {
                return new Result(resultStatus: ResultStatus.Success, $"{entity.Title} created");
            }

            return new Result(resultStatus: ResultStatus.Error, $"{entity.Title} is not created");

        }

        public async Task<IResult> DeleteAsync(int id, string modifiedByName)
        {
            var entity = await _unitOfWork.Posts.GetAsync(c => c.Id == id);
            if (entity == null) return new Result(ResultStatus.Error, $"{id} not found");
            entity.SetIsDeleted(false);
            entity.SetModifiedByName(modifiedByName);
            await _unitOfWork.Posts.UpdateAsync(entity);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result > 0) return new Result(ResultStatus.Success, $"{entity.Title} removed");
            return new Result(ResultStatus.Error, $"{entity.Title} not removed");
        }

        public async Task<IResult> HardDeleteAsync(int id)
        {
            var entity = await _unitOfWork.Posts.GetAsync(c => c.Id == id);
            if (entity == null) return new Result(ResultStatus.Error, $"{id} not found");
            await _unitOfWork.Posts.DeleteAsync(entity);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result > 0) return new Result(ResultStatus.Success, $"{entity.Title} removed");
            return new Result(ResultStatus.Error, $"{entity.Title} not removed");
        }

        public async Task<IResult> UpdateAsync(PostUpdateDto dto, string createdByName)
        {
            var entity = await _unitOfWork.Posts.GetAsync(c => c.Id == dto.Id);
            if (entity == null) return new Result(ResultStatus.Error, $"{dto.Id} not found");
            entity.Title = dto.Title;
            entity.CategoryId = dto.CategoryId;
            entity.Content = dto.Content;
            entity.Date = dto.Date;
            entity.SeoAuthor = dto.SeoAuthor;
            entity.SeoDescription = dto.SeoDescription;
            entity.SeoTags = dto.SeoTags;
            entity.Thumbnail = dto.Thumbnail;
            entity.UserId = dto.UserId;
            await _unitOfWork.Posts.UpdateAsync(entity);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result > 0) return new Result(ResultStatus.Success, $"{entity.Title} modified");
            return new Result(ResultStatus.Error, $"{entity.Title} not modified");
        }



        #endregion
    }
}
