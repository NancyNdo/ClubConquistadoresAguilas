﻿using Models;

namespace Application.IService;

public interface IPersonService
{
    Task<bool> Insert(Person model);
    Task<bool> Update(Person model);
    Task<bool> Delete(int id1, int id2 = 0);
    Task<Person> Get(int id1, int id2 = 0);
    Task<IQueryable<Person>> GetAll();
}