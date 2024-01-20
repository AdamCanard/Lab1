using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    enum RelationType
    {
        Sister,
        Brother,
        Mother,
        Father
    }
    internal class Relation
    {
        private RelationType RelationshipType;
        private Person person1;
        private Person person2;
        public Relation(Person person1, Person person2, string relation)
        {
            this.person1 = person1;
            this.person2 = person2;
            switch (relation)
            {
                case "sister":
                    this.RelationshipType = RelationType.Sister;
                    break;
                case "brother":
                    this.RelationshipType = RelationType.Brother;
                    break;
                case "mother":
                    this.RelationshipType = RelationType.Mother;
                    break;
                case "father":
                    this.RelationshipType = RelationType.Father;
                    break;
            }
                
        }

        public string ShowRelationShip(Person personA, Person personB)
        {
            string relation = "No relationship";
            if ((person1 == personA || person1 == personB) && (person2 == personA || person2 == personB))
            { 
                if (this.RelationshipType == RelationType.Sister)
                {
                    relation = "Sisterhood";
                }
                else if (this.RelationshipType == RelationType.Brother)
                {
                    relation = "Brotherhood";
                }
                else if (this.RelationshipType == RelationType.Mother)
                {
                    relation = "Motherhood";
                }
                else if (this.RelationshipType == RelationType.Father)
                {
                    relation = "Fatherhood";
                }
            }

            return $"Relationship between {personA.FirstName} and {personB.FirstName} is: {relation}";
        }
    }
    
}
