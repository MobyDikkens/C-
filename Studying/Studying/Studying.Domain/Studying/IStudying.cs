using System;

namespace Studying.Domain.Studying
{
    public interface IStudying
    {
        Action GetStudingStategy();
        int Profit { get; }
    }
}