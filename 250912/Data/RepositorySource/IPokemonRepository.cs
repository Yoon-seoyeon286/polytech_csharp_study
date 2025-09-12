namespace _250912.Data.RepositorySource;

public interface IPokemonRepository
{
    Task<List<Post>> GetPostsAsync();
    Task<T> GetPostByIdAsync<T>(int id);
    Task<T> CreatePostAsync<T>(Post post);
    Task<T> UpdatePostAsync<T>(Post post);
    Task<bool> DeletePostAsync(int id);
    
    public Task<Pokemon?> GetPokemonByNameAsync(string pokemonName);

}