using glabAPI.Data;
using glabAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace glabAPI.Controllers
{
    [Route("[controller]")]//this will determine the url to call the action
    [ApiController]
    public class SongsController : ControllerBase
    {
        private APIDbContext _dbContext;
        public SongsController(APIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet] //could just name it Get
        public IEnumerable<Song> GetSongs()
        {
            return _dbContext.Songs;
        }

        [HttpGet("{id}")]
        public Song GetSong(int id)
        {
            return _dbContext.Songs.Find(id);
        }

        //add FromBody to let it know that the data we need to add is coming 
        //from the body of the request.
        [HttpPost]
        public void PostSong([FromBody] Song song)
        {
            _dbContext.Songs.Add(song);
            _dbContext.SaveChanges();
        }

        [HttpPut("{Id}")]
        public void PutSong(int id, [FromBody] Song song)
        {
            Song s = _dbContext.Songs.Find(id);
            s.Title = song.Title;
            s.Language = song.Language;
            _dbContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Song s = _dbContext.Songs.Find(id);
            _dbContext.Songs.Remove(s);
            _dbContext.SaveChanges();
        }
    }
}
