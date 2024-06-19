using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCharacter
{
    public class Character
    {
        public string nameCharacter;
        public float lifePoints;
        public float defPoints;
        public float attakPoints;
        public Character()
        {
            nameCharacter = "Toto";
            attakPoints = 50;
            defPoints = 20;
            lifePoints = 70;

        }

        public Character(string _nameCharacter, string _defPoints, string _attakPoints, string _lifePoints)
        {
            nameCharacter = _nameCharacter;
            defPoints = float.Parse(_defPoints);
            attakPoints = float.Parse(_attakPoints);
            lifePoints = float.Parse(_lifePoints);
        }
        public void Attaque( Character j2)
        {
            if (this.attakPoints > j2.defPoints)
            {
                Console.WriteLine(nameCharacter + " attaque " + j2.nameCharacter);
                j2.lifePoints = j2.lifePoints - (attakPoints - j2.defPoints);
                Console.WriteLine(nameCharacter + " a pour nombre de points de vie : " + lifePoints);
            }
            else
            {
                Console.WriteLine("Rien ne se passe");
            }
        }

        public void Combat(Character j2)
        {
            bool booleen = false;
            //Condition pour savoir si une attaque se déroule correctement
            while (lifePoints > 0 && j2.lifePoints > 0)
            {
                if (booleen == false)
                {
                    Attaque(j2);
                    booleen = true;

                }
                else
                {
                    j2.Attaque(this);
                    booleen = false;

                }
            }
            //Condition de victoire, défaite et egalité
            if (this.lifePoints < 0 && j2.lifePoints >= 0)
            {
                Console.WriteLine(j2.nameCharacter + " qui gagne avec le nombre de points de vie : " + j2.lifePoints);

            }
            else if (j2.lifePoints < 0 && this.lifePoints >= 0)
            {
                Console.WriteLine( this.nameCharacter + " qui gagne avec le nombre de points de vie: " + this.lifePoints);

            }
            else
            {
                Console.WriteLine("Vous avez fini par une égalité");

            }
        }

    }
}