using System.Collections.Generic;

namespace Ancestralis
{
    // A node correspond to a specific individual
    public class Node
    {
        public List<Node> parents = new List<Node>();
        public List<Node> childrens = new List<Node>();
        public List<MariageDatas> mariages = new List<MariageDatas>();

        public LocalizationDateTime birth;
        public LocalizationDateTime death;

        public string lastName;
        public string firstName;
        public string surname;

        public string sources;
        public string details;
    }

    public class MariageDatas
    {
        public Node spouse;
        public LocalizationDateTime mariage;
    }
}
