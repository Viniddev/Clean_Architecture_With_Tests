
using App.Domain.Abstractions;

namespace App.Domain.Repository;

public interface IRepository<T> where T : IAggregateRoot;
