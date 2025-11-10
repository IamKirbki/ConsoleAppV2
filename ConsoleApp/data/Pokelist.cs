using ConsoleApp.Models;

namespace ConsoleApp.data
{
    static class Pokelist
    {
        public static readonly List<Pokemon> Pokemons = new()
        {
            new() {Id = 6, Name = "Charizard", Type = ["Fire", "Flying"], Hp = 78, Attack = 84, Defense = 78, Speed = 100, Ability = "Blaze", Region = "Kanto"},
            new() {Id = 25, Name = "Pikachu", Type = ["Electric"], Hp = 35, Attack = 55, Defense = 40, Speed = 90, Ability = "Static", Region = "Kanto"},
            new() {Id = 94, Name = "Gengar", Type = ["Ghost", "Poison"], Hp = 60, Attack = 65, Defense = 60, Speed = 110, Ability = "Cursed Body", Region = "Kanto"},
            new() {Id = 248, Name = "Tyranitar", Type = ["Rock", "Dark"], Hp = 100, Attack = 134, Defense = 110, Speed = 61, Ability = "Sand Stream", Region = "Johto"},
            new() {Id = 448, Name = "Lucario", Type = ["Fighting", "Steel"], Hp = 70, Attack = 110, Defense = 70, Speed = 90, Ability = "Steadfast", Region = "Sinnoh"},
            new() {Id = 635, Name = "Hydreigon", Type = ["Dark", "Dragon"], Hp = 92, Attack = 105, Defense = 90, Speed = 98, Ability = "Levitate", Region = "Unova"}
        };
    }
}
