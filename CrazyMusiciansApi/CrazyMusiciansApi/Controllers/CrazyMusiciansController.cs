using CrazyMusiciansApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusiciansApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyMusiciansController : ControllerBase
    {
        private static List<CrazyMusicians> _crazyMusicians = new List<CrazyMusicians>()
        {
            new CrazyMusicians { Id = 1, MusicianName = "Ahmet Çalgı", Job = "Famous Musical Instrument Player", FunFeature = "Always hits the wrong note, but it's so much fun" },
            new CrazyMusicians { Id = 2, MusicianName = "Zeynep Melodi", Job = "Famous Melody Writer", FunFeature = "Their songs are misunderstood, but so famous" },
            new CrazyMusicians { Id = 3, MusicianName = "Cemil Akkor", Job = "Crazy Accordist", FunFeature = "His chords change frequently but he is surprisingly talented" },
            new CrazyMusicians { Id = 4, MusicianName = "Fatma Nota", Job = "Surprise note generator", FunFeature = "She always prepares surprises while producing notes" },
            new CrazyMusicians { Id = 5, MusicianName = "Hasan Ritim", Job = "Rhythm Monster", FunFeature = "He does every rhythm in his own way, it never fits but it's funny" },
            new CrazyMusicians { Id = 6, MusicianName = "Elif Armoni", Job = "Harmony master", FunFeature = "She sometimes plays her harmonies wrong but she is very creative." },
            new CrazyMusicians { Id = 7, MusicianName = "Ali Perde", Job = "Fret user", FunFeature = "Plays each key differently, always surprising" },
            new CrazyMusicians { Id = 8, MusicianName = "Ayşe Rezonans", Job = "Resonance expert", FunFeature = "She is expert in resonance, but sometimes makes a lot of noise" },
            new CrazyMusicians { Id = 9, MusicianName = "Murat Ton", Job = "Tone enthusiast", FunFeature = "The difference in intonation is sometimes funny but quite interesting" },
            new CrazyMusicians { Id = 10, MusicianName = "Selin Akor", Job = "Chord Wizard", FunFeature = "Sometimes when she changes the chords she creates a magical atmosphere" },
        };

        [HttpGet]
        public IEnumerable<CrazyMusicians> GetAll()
        {
            return _crazyMusicians;
        }

        [HttpGet("{id:int:min(1)}")]

        public IActionResult Search([FromQuery] string keyword)
        {
            var crazyMusicians = _crazyMusicians.Where(x => x.MusicianName.Contains(keyword) || x.MusicianName.Contains(keyword)).ToList();

            if (crazyMusicians.Count == 0)
                return NotFound();

            return Ok(crazyMusicians);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CrazyMusicians crazyMusicians)
        {
            var id = _crazyMusicians.Max(x => x.Id) + 1;
            crazyMusicians.Id = id;
            _crazyMusicians.Add(crazyMusicians);

            return CreatedAtAction(nameof(GetAll), new { id = crazyMusicians.Id }, crazyMusicians);
        }

        [HttpPut]

        public IActionResult Put(int id, [FromBody] CrazyMusicians crazyMusicians)
        {
            if (crazyMusicians == null || id != crazyMusicians.Id)
            {
                return BadRequest();
            }

            var existingCrazyMusicians = _crazyMusicians.FirstOrDefault(x => x.Id == id);

            if (existingCrazyMusicians == null)
            {
                return NotFound();
            }

            existingCrazyMusicians.MusicianName = crazyMusicians.MusicianName;

            return Ok(existingCrazyMusicians);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateMusicianName(int id, [FromBody] string newName)
        {
            var MusicianName = _crazyMusicians.Find(u => u.Id == id);

            if (MusicianName == null)
            {
                return NotFound("Musician not found");
            }


            MusicianName.MusicianName = newName;

            return Ok(MusicianName);
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var existingCrazyMusicians = _crazyMusicians.FirstOrDefault(y => y.Id == id);

            if (existingCrazyMusicians == null)
            {
                return NotFound();
            }

            _crazyMusicians.Remove(existingCrazyMusicians);

            return NoContent();
        }
    }

    
}
