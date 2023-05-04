﻿using HortIntelligentApi.Application.Dtos;
using HortIntelligentApi.Domini.Entitats;

namespace HortIntelligentApi.Dades.Repositoris.Interficies
{
    public interface IVegetalRepository
    {
        public Task<IList<Vegetal>> GetAll();
    }
}
