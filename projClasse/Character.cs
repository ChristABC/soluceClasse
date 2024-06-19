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
        public float lifeDef;
        public float lifeAttak;
        public Character()
        {
            nameCharacter = "Toto";
            lifeAttak = 50;
            lifeDef = 20;
            lifePoints = 70;

        }

        public Character(string _nameCharacter, string _lifeDef, string _lifeAttak, string _lifePoints)
        {
            nameCharacter = _nameCharacter;
            lifeDef = float.Parse(_lifeDef);
            lifeAttak = float.Parse(_lifeAttak);
            lifePoints = float.Parse(_lifePoints);
        }
        public void Attaque( Character j2)
        {
            if (this.lifeAttak > j2.lifeDef)
            {
                Console.WriteLine("Le " + nameCharacter + " attaque le " + j2.nameCharacter);
                j2.lifePoints = j2.lifePoints - (lifeAttak - j2.lifeDef);
                Console.WriteLine("Le joureur " + nameCharacter + " a pour nombre de points de vie : " + lifePoints);
            }
            else
            {
                Console.WriteLine("Rien ne se passe");
            }
        }

        public void Combat(Character j2)
        {
            bool booleen = false;
            
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
            if (this.lifePoints < 0 && j2.lifePoints >= 0)
            {
                Console.WriteLine("Le joueur " + j2.nameCharacter + "qui a gagné avec ce score: " + j2.lifePoints);

            }
            else if (j2.lifePoints < 0 && this.lifePoints >= 0)
            {
                Console.WriteLine("Le joueur " + this.nameCharacter + " a gagné avec ce score : " + this.lifePoints);

            }
            else
            {
                Console.WriteLine("Vous avez fini égalité");

            }
        }

    }
}