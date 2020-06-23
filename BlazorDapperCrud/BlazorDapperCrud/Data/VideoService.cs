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
                const string query =
                    "INSERT INTO Video(Title,DatePublished,IsActive)VALUES(@Title, @DatePublished, @IsActive)";
                await conn.ExecuteAsync(query, new {video.Title, video.DatePublished, video.IsActive},
                    commandType: CommandType.Text);
            }

            return true;
        }
    }
}
