using GenogramGenerator.Core;

namespace GenogramGenerator.Tests
{
    static public class DemoFamily
    {
        public static Family Create()
        {
            var us = new Family();
            var me = new Woman
                {
                    Name = "Subject Person",
                    Generation = 1,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 700
                };
            var sister = new Woman
                {
                    Name = "Sister Person",
                    Generation = 1,
                    DistanceToPrimaryLineage = 2,
                    XPosition = 525
                };
            var brother = new Man
                {
                    Name = "Brother Person",
                    Generation = 1,
                    DistanceToPrimaryLineage = 2,
                    XPosition = 850
                };
            var mom = new Woman
                {
                    Name = "Mother Person",
                    Generation = 2,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 1050
                };
            var uncle = new Man
                {
                    Name = "Mom's Brother",
                    Generation = 2,
                    DistanceToPrimaryLineage = 2,
                    XPosition = 963
                };
            var uncleswife = new Woman
                {
                    Name = "Uncle's Wife",
                    Generation = 2,
                    DistanceToPrimaryLineage = 3,
                    XPosition = 1006
                };
            var dad = new Man
                {
                    Name = "Father Person",
                    Generation = 2,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 350
                };
            var aunt = new Woman
                {
                    Name = "Dad's Sister",
                    Generation = 2,
                    DistanceToPrimaryLineage = 2,
                    XPosition = 438
                };
            var momsmom = new Woman
                {
                    Name = "Maternal Grandmother",
                    Generation = 3,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 1225
                };
            var momsdad = new Man
                {
                    Name = "Maternal Grandfather",
                    Generation = 3,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 875
                };
            var dadsmom = new Woman
                {
                    Name = "Paternal Grandmother",
                    Generation = 3,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 525
                };
            var dadsdad = new Man
                {
                    Name = "Paternal Grandfather",
                    Generation = 3,
                    DistanceToPrimaryLineage = 1,
                    XPosition = 175
                };
            us.SetAsFamily(me, sister, brother, mom, dad, momsdad, momsmom, dadsdad, dadsmom, uncle, aunt, uncleswife);
            mom.Is.MarriedTo(dad).AndTheyAreTheParentsOf(me, sister, brother);
            momsdad.Is.MarriedTo(momsmom).AndTheyAreTheParentsOf(mom, uncle);
            dadsmom.Is.MarriedTo(dadsdad).AndTheyAreTheParentsOf(dad, aunt);
            uncle.Is.MarriedTo(uncleswife);
            return us;
        }
    }
}