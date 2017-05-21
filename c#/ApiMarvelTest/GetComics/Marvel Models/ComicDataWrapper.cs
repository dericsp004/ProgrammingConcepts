using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetComics.Marvel_Models
{
    public class Image
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Series
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Date
    {
        public string type { get; set; }
        public string date { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public double price { get; set; }
    }

    public class Thumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

    public class CreatorSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }

    public class CreatorList
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<CreatorSummary> creators { get; set; }
        public int returned { get; set; }
    }

    public class CharacterSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }

    public class CharacterList
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<CharacterSummary> items { get; set; }
        public int returned { get; set; }
    }

    public class ComicSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class SeriesSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class StorySummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class StoryList
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<StorySummary> items { get; set; }
        public int returned { get; set; }
    }

    public class EventSummary
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class EventList
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }
  
    public class TextObject
    {
        public string type;
        public string language;
        public string text;
    }

    public class Comic
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public int issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public List<TextObject> textObjects { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public Series series { get; set; }
        public List<ComicSummary> variants { get; set; }
        public List<ComicSummary> collections { get; set; }
        public List<ComicSummary> collectedIssues { get; set; }
        public List<Date> dates { get; set; }
        public List<Price> prices { get; set; }
        public Thumbnail thumbnail { get; set; }
        public List<Image> images { get; set; }
        public CreatorList creators { get; set; }
        public CharacterList characters { get; set; }
        public StoryList stories { get; set; }
        public EventList events { get; set; }
    }

    public class ComicDataContainer
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<Comic> comics { get; set; }
    }

    public class ComicDataWrapper
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public ComicDataContainer data { get; set; }
    }
}
