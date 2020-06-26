using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDapperCrud.Data
{
    public interface IVideoService
    {
        Task<bool> VideoInsert(Video video);
        Task<IEnumerable<Video>> VideoList { get; set; }
    }
}