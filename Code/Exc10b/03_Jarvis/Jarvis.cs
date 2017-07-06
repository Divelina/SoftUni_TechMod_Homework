using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Jarvis
{
    public class Arm
    {
        public long EnergyCons { get; set; }
        public int Reach { get; set; }
        public int FingerNum { get; set; }
    }

    public class Leg
    {
        public long EnergyCons { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }

    public class Torso
    {
        public long EnergyCons { get; set; }
        public double ProcessorSize { get; set; }
        public string HousingMat { get; set; }
    }

    public class Head
    {
        public long EnergyCons { get; set; }
        public int IQ { get; set; }
        public string SkinMat { get; set; }
    }

    public class Robot
    {
        public Head theHead { get; set; }
        public Torso theTorso { get; set; }
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
    }

    public class Jarvis
    {
        public static void Main()
        {
            var maxEnergy = long.Parse(Console.ReadLine());
            var jarvis = InnitiateJarvis();

            var parts = Console.ReadLine();

            while (parts != "Assemble!")
            {
                var split = parts.Split(' ').ToArray();

                var partType = split[0];
                var energyConsmpt = long.Parse(split[1]);
                
                if (partType == "Head")
                {
                    if (energyConsmpt < jarvis.theHead.EnergyCons)
                    {
                        jarvis.theHead = new Head
                        {
                            EnergyCons = energyConsmpt,
                            IQ = int.Parse(split[2]),
                            SkinMat = split[3]
                        };
                    }
                }
                else if (partType == "Torso")
                {
                    if (energyConsmpt < jarvis.theTorso.EnergyCons)
                    {
                        jarvis.theTorso = new Torso
                        {
                            EnergyCons = energyConsmpt,
                            ProcessorSize = double.Parse(split[2]),
                            HousingMat = split[3]
                        };
                    }
                }
                else if (partType == "Arm")
                {
                    var arm = new Arm
                    {
                        EnergyCons = energyConsmpt,
                        Reach = int.Parse(split[2]),
                        FingerNum = int.Parse(split[3])
                    };

                    if (arm.EnergyCons < jarvis.Arms.First().EnergyCons)
                    {
                        jarvis.Arms.RemoveAt(0);   
                        jarvis.Arms.Add(arm);
                    }
                    else if (arm.EnergyCons < jarvis.Arms.Skip(1).First().EnergyCons)
                    {
                        jarvis.Arms.RemoveAt(1);
                        jarvis.Arms.Add(arm);
                    }
                }
                else if (partType == "Leg")
                {
                    var leg = new Leg
                    {
                        EnergyCons = energyConsmpt,
                        Strength = int.Parse(split[2]),
                        Speed = int.Parse(split[3])
                    };

                    if (leg.EnergyCons < jarvis.Legs.First().EnergyCons)
                    {
                        jarvis.Legs.RemoveAt(0);
                        jarvis.Legs.Add(leg);
                    }
                    else if (leg.EnergyCons < jarvis.Legs.Skip(1).First().EnergyCons)
                    {
                        jarvis.Legs.RemoveAt(1);
                        jarvis.Legs.Add(leg);
                    }
                }
                parts = Console.ReadLine();
            }

            long totalEnergy = jarvis.Arms
                .Where(a => a.EnergyCons < long.MaxValue).Sum(a => a.EnergyCons)
                + jarvis.Legs
                .Where(a => a.EnergyCons < long.MaxValue).Sum(l => l.EnergyCons);

            int partCount = 0;

            if (jarvis.theHead.EnergyCons < long.MaxValue)
            {
                partCount++;
                totalEnergy += jarvis.theHead.EnergyCons;
            }
            if ((jarvis.theTorso.EnergyCons < long.MaxValue))
            {
                partCount++;
                totalEnergy += jarvis.theTorso.EnergyCons;
            }

            partCount += jarvis.Arms.Where(a => a.EnergyCons < long.MaxValue).Count()
                + jarvis.Legs.Where(l => l.EnergyCons < long.MaxValue).Count();

            jarvis.Arms = jarvis.Arms.OrderBy(a => a.EnergyCons).ToList();
            jarvis.Legs = jarvis.Legs.OrderBy(l => l.EnergyCons).ToList();

            if (maxEnergy < totalEnergy)
            {
                Console.WriteLine($"We need more power!");
            }
            else if (partCount != 6)
            {
                Console.WriteLine($"We need more parts!");
            }
            else
            {
                Console.WriteLine($"Jarvis:");
                Console.WriteLine($"#Head:");
                Console.WriteLine($"###Energy consumption: {jarvis.theHead.EnergyCons}");
                Console.WriteLine($"###IQ: {jarvis.theHead.IQ}");
                Console.WriteLine($"###Skin material: {jarvis.theHead.SkinMat}");
                Console.WriteLine($"#Torso:");
                Console.WriteLine($"###Energy consumption: {jarvis.theTorso.EnergyCons}");
                Console.WriteLine($"###Processor size: {jarvis.theTorso.ProcessorSize:F1}");
                Console.WriteLine($"###Corpus material: {jarvis.theTorso.HousingMat}");

                foreach (var item in jarvis.Arms)
                {
                    Console.WriteLine($"#Arm:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyCons}");
                    Console.WriteLine($"###Reach: {item.Reach}");
                    Console.WriteLine($"###Fingers: {item.FingerNum}");
                }

                foreach (var item in jarvis.Legs)
                {
                    Console.WriteLine($"#Leg:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyCons}");
                    Console.WriteLine($"###Strength: {item.Strength}");
                    Console.WriteLine($"###Speed: {item.Speed}");
                }
            }
        }

        public static Robot InnitiateJarvis()
        {
            var theRobot = new Robot
            {
                theHead = new Head
                {
                    EnergyCons = long.MaxValue,
                    IQ = int.MinValue,
                    SkinMat = ""
                },

                theTorso = new Torso
                {
                    EnergyCons = long.MaxValue,
                    ProcessorSize = 0.0,
                    HousingMat = ""
                },

                Arms = new List<Arm>
                {
                    new Arm
                    {
                        EnergyCons = long.MaxValue,
                        Reach = 0,
                        FingerNum =0
                    },

                    new Arm
                    {
                        EnergyCons = long.MaxValue,
                        Reach = 0,
                        FingerNum = 0
                    }
                },

                Legs = new List<Leg>
                {
                    new Leg
                    {
                        EnergyCons = long.MaxValue,
                        Strength = 0,
                        Speed =0
                    },

                    new Leg
                    {
                        EnergyCons = long.MaxValue,
                        Strength = 0,
                        Speed = 0
                    }
                }
            };

            return theRobot;
        }
    }


}
