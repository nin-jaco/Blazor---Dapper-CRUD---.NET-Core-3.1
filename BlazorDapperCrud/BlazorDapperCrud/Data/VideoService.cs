using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlazorDapperCrud.Data
{
    public class VideoService : IVideoService
    {
        //database connections
        private readonly SqlConnectionConfiguration _configuration;
        private Task<IEnumerable<Video>> _videoList;

        public VideoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        //add record
        public async Task<bool> VideoInsert(Video video)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Title", video.Title, DbType.String);
                parameters.Add("DatePublished", video.DatePublished, DbType.Date);
                parameters.Add("IsActive", video.IsActive, DbType.Boolean);
                //stored procedure
                await conn.ExecuteAsync("spVideo_Insert", parameters, commandType: CommandType.StoredProcedure);
                //raw sql method
                /*const string query =
                    "INSERT INTO Video(Title,DatePublished,IsActive)VALUES(@Title, @DatePublished, @IsActive)";
                await conn.ExecuteAsync(query, new {video.Title, video.DatePublished, video.IsActive},
                    commandType: CommandType.Text);*/
            }

            return true;
        }


        //GetAll
        public async Task<IEnumerable<Video>> VideoList()
        {
            IEnumerable<Video> videos;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                videos = await conn.QueryAsync<Video>("spVideo_GetAll", commandType: CommandType.StoredProcedure);
            }

            return videos;
        }

        //get one by id
        public async Task<Video> GetOne(int id)
        {
            Video video = new Video();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);


            using (var conn = new SqlConnection(_configuration.Value))
            {
                video = await conn.QueryFirstOrDefaultAsync<Video>("spVideo_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }

            return video;
        }

        //update
        public async Task<bool> VideoUpdate(Video video)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", video.Id, DbType.Int32);
                parameters.Add("Title", video.Title, DbType.String);
                parameters.Add("DatePublished", video.DatePublished, DbType.Date);
                parameters.Add("IsActive", video.IsActive, DbType.Boolean);
                await conn.ExecuteAsync("spVideo_Update", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        //Delete
        public async Task<bool> VideoDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spVideo_Delete", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }
    }
}
