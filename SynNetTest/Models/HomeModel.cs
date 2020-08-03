using System.IO;
using System.Collections.Generic;
using Syn.WordNet;
using Microsoft.AspNetCore.Mvc;

namespace SynNetTest.Models
{


    public class HomeModel
    {
        public string directory { get; set; }
        public WordNetEngine wordNet { get; set; }
        [FromForm]
        public string word { get; set; }
        public List<SynSet> synSetList { get; set; }

        //load words to access
        public string Load()
        {
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, "data.adj")), PartOfSpeech.Adjective);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, "data.adv")), PartOfSpeech.Adverb);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, "data.noun")), PartOfSpeech.Noun);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, "data.verb")), PartOfSpeech.Verb);

            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, "index.adj")), PartOfSpeech.Adjective);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, "index.adv")), PartOfSpeech.Adverb);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, "index.noun")), PartOfSpeech.Noun);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, "index.verb")), PartOfSpeech.Verb);


            wordNet.Load();
            return "Database Loaded Successfully";

        }
    }
}

