using ConsoleApp.data;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.UI;

namespace ConsoleApp.Commands
{
    public class ListCommand : ICommand
    {
        public string Name => "list";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Write("Please select the pokemon you want to inspect");

            string[] pokeNames = Pokelist.Pokemons.Select(x => x.Name).ToArray();
            foreach (var pokemon in pokeNames.Select((value, index) => new { value, index }))
            {
                _ui.Write(pokemon.index + ": " + pokemon.value);
            }

            bool HasCorrectPokemon = false;

            while (!HasCorrectPokemon)
            {
                string Input = _ui.Read();
                if (Input == "exit")
                {
                    return;
                }

                if (int.TryParse(Input, out int index))
                {
                    if (index < Pokelist.Pokemons.Count && index >= 0)
                    {
                        Pokemon SelectedPokemon = Pokelist.Pokemons[index];
                        Dictionary<string, string> PokemonProperties = SelectedPokemon.GetValues();

                        foreach (KeyValuePair<string, string> entry in PokemonProperties)
                        {
                            _ui.Write(entry.Key + ": " + entry.Value);
                        }

                        HasCorrectPokemon = true;
                    }
                    else
                    {
                        _ui.Write("Please select a correct index");
                    }
                }
                else
                {
                    _ui.Write("Please select a number");
                }
            }
        }
    }
}
