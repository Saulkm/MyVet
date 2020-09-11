using MyVet.Web.Data.Entities;
using MyVet.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _datacontext;

        public ConverterHelper(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        public async Task<Pet> ToPetAsync(PetViewModel model, string path)
        {
            return new Pet
            {
                Agendas = model.Agendas,
                Born = model.Born,
                Histories = model.Histories,
                Id = model.Id,
                ImageUrl = model.ImageUrl,
                Name = path,
                Owner = await _datacontext.Owners.FindAsync(model.OwnerId),
                PetType = await _datacontext.PetTypes.FindAsync(model.PetTypeId),
                Race = model.Race,
                Remarks = model.Remarks
            };
        }
    }
}
