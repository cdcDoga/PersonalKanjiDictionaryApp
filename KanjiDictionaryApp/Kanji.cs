using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiDictionaryApp
{
    public enum Structure
    {
        NOUN = 0,
        VERB = 1,
        ADJACTIVE = 2,
        ADVERB = 3
    }

    public class Kanji
    {
        public string character;
        public List<string> onyomi, kunyomi, meaning;
        public List<Structure> structure;
        public int num_of_stroke;

        public Kanji()
        {
            character = "";
            onyomi = new List<string>();
            kunyomi = new List<string>();
            meaning = new List<string>();
            structure = new List<Structure>();
            num_of_stroke = 0;
        }

        public Kanji(string character, List<string> onyomi, List<string> kunyomi,
            List<string> meaning, List<Structure> structure, int num_of_stroke)
        {
            this.character = character;
            this.onyomi = onyomi;
            this.kunyomi = kunyomi;
            this.meaning = meaning;
            this.structure = structure;
            this.num_of_stroke = num_of_stroke;
        }

        public void SetCharacter(string character) { this.character = character; }
        public string GetCharacter() { return character; }

        public void SetOnyomi(List<string> onyomi) { this.onyomi = onyomi; }
        public List<string> GetOnyomi() { return onyomi; }

        public void SetKunyomi(List<string> kunyomi) { this.kunyomi = kunyomi; }
        public List<string> GetKunyomi() { return kunyomi; }

        public void SetMeaning(List<string> meaning) { this.meaning = meaning; }
        public List<string> GetMeaning() { return meaning; }

        public void SetStructure(List<Structure> structure) { this.structure = structure; }
        public List<Structure> GetStructure() { return structure; }

        public void SetNumOfStrokes(int num_of_stroke) { this.num_of_stroke = num_of_stroke; }
        public int GetNumOfStrokes() { return num_of_stroke; }

        public bool matches(string attribute)
        {
            foreach (var item in onyomi) { if (item.Contains(attribute)) return true; }
            foreach (var item in kunyomi) { if (item.Contains(attribute)) return true; }
            foreach (var item in meaning) { if (item.Contains(attribute)) return true; }
            if (Convert.ToString(num_of_stroke) == attribute) return true;

            return false;
        }
    }
}
