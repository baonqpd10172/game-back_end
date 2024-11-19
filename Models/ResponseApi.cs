using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerGame106.Data;

namespace ServerGame106.Models
{
    public class ResponseApi
    {
        private readonly ApplicationDbContext _db;
        protected ResponseApi _response;
        public APIGameController(ApplicationDbContext db)
        {
            _db = db;
            _response = new();
        }
        public bool IsSuccess { get; set; }
        public string Notification { get; set; }
        public object Data { get; set; }
    }
    
    
}
