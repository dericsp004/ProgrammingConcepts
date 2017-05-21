using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetComics.Marvel_Models;

namespace GetComics
{
    class Program
    {
        static async void Main(string[] args)
        {
            MarvelFacade marvel = new MarvelFacade();
            ComicDataWrapper result = await marvel.getCurrentComics<ComicDataWrapper>();
            Console.ReadKey();
        }
    }
}
