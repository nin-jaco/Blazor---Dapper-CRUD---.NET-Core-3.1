using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public interface IVideoService
    {
        Task<bool> VideoInsert(Video video);
        Task<IEnumerable<Video>> VideoList();
        Task<Video> GetOne(int id);
        Task<bool> VideoUpdate(Video video);
        Task<bool> VideoDelete(int id);
    }
}