using _250915.Data.Models;

namespace _250915.Data.Common;

public  abstract record Result<TData,TError>
{
    public sealed record Suceess(Pokemon data ) :  Result<TData,TError>;
    public sealed record Error(TError error) :  Result<TData,TError>;
}

