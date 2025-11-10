namespace ConsoleApp.Models
{
    public class Pokemon
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string[] Type { get; set; }
        public required int Hp { get; set; }
        public required int Attack { get; set; }
        public required int Defense { get; set; }
        public required int Speed { get; set; }
        public required string Ability { get; set; }
        public required string Region { get; set; }

        public Dictionary<string, string> GetValues()
        {
            return new Dictionary<string, string>
            {
                { "Id", Id.ToString() },
                { "Name", Name },
                { "Type", string.Join(", ", Type) },
                { "Hp", Hp.ToString() },
                { "Attack", Attack.ToString() },
                { "Defense", Defense.ToString() },
                { "Speed", Speed.ToString() },
                { "Ability", Ability },
                { "Region", Region }
            };
        }
    }
}
