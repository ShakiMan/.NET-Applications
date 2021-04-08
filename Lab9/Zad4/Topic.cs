using System;
using System.Collections.Generic;
using System.Text;

//Radosław Ścigała, 246997

namespace Zad4
{
    public class Topic
    {
        private static Dictionary<string, int> values;
        public static int Counter { get; set; } = 1;

        static Topic()
        {
            values = new Dictionary<string, int>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public Topic(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public static Topic GetTopicByTitle(string title)
        {
            int id;
            if (!values.TryGetValue(title, out id))
            {
                int.TryParse(title.Replace("topic", ""), out id);
                if (id == 0)
                {
                    id = Counter++;
                }
                values.Add(title, id);
            }

            return new Topic(id, title);
        }

        public override string ToString()
        {
            return $"id: {Id}";
        }
    }
}
