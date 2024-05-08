using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeAppConsole;
public class Genre
{
    public int Id { get; set; }
    public string Type { get; set; }
    public List<Anime> Animes { get; set; }
}
