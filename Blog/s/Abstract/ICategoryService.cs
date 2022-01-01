using System.Threading.Tasks;
using BlogEntities.Dtos;
using BlogShared.Utilities.Results.Abstract;

namespace BlogServices.Abstract
{
public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int id);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
        Task<IResult> AddAsync(CategoryAddDto dto, string createdByName);
        Task<IResult> UpdateAsync(CategoryUpdateDto dto, string createdByName);
        Task<IResult> DeleteAsync(int id, string modifiedByName);
        Task<IResult> HardDeleteAsync(int id);
    }
}


