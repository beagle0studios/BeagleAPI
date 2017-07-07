using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    class SDTest : IBeagleBase
    {
        private Word _title = "SDTEST_";
        public int ID = 0;

        public Word Title
        {
            get
            {
                return _title;
            }
            set { _title = value; }
        }

        public BeagleBaseType BBaseType
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void RegisterToBaseBase()
        { }

        public void UnregisterBaseBase()
        { }
    }

    public class SimpleDatabase
    {
        public SimpleDatabase()
        {
            SDBMainCl<SDTest> Wacker = new SDBMainCl<SDTest>(10);
            // Spieler der Mannschaft hinzufügen 
            Wacker[0] = new SDTest { Title = "Eigentlich", ID = 1 };
            Wacker[1] = new SDTest { Title = "Bin", ID = 1 };
            Wacker[2] = new SDTest { Title = "Ich", ID = 1 };
            Wacker[3] = new SDTest { Title = "Eine Methode", ID = 1 };
            // Spieler suchen
            Console.Write("Spieler suchen: ... ");
            string spieler = Console.ReadLine();
            if (Wacker[spieler] != null)
            {
                Console.WriteLine("{0} gefunden, Alter = {1}", Wacker[spieler].Title, Wacker[spieler].ID);
                Console.WriteLine(Wacker[spieler].ID);
            }
            else
                Console.WriteLine("Der Spieler gehört nicht zum Team.");
            Console.ReadLine();
        }
    }

    // Mannschaft
    public class SDBMainCl<T> where T : IBeagleBase
    {

        private T[] team;
        private int MaxVal = 25;

        public SDBMainCl(int maxVal)
        {
            team = new T[maxVal];
            this.MaxVal = maxVal;
        }

        // Indexer  
        public T this[int index]
        {
            get { return team[index]; }
            set
            {
                // prüfen, ob der Index schon besetzt ist      
                if (team[index] == null)
                    team[index] = value;
                else
                    // nächsten freien Index suchen
                    for (int i = 0; i < MaxVal; i++)
                        if (team[i] == null)
                        {
                            team[i] = value;
                            return;
                        }
            }
        }

        public T this[string name]
        {
            get
            {
                for (int index = 0; index < MaxVal; index++)
                {
                    if (team[index] != null && team[index].Title == name)
                        return team[index];
                }
                return team[0];
            }
        }
    }
}
