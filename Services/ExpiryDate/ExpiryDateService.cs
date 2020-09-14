using Repositories.ExpiryDate;
using Repositories.ExpiryDate.Models;
using Services.ExpiryDate.Models;
using Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ExpiryDate
{
    public class ExpiryDateService : IExpiryDateService
    {
        private IExpiryDateRepository _expiryDateRepository;
        private TransferObjectMapper _transferObjectMapper;
        private AccessObjectMapper _accessObjectMapper;
        public ExpiryDateService(IExpiryDateRepository expiryDateRepository)
        {
            _expiryDateRepository = expiryDateRepository;
        }
        public List<CacheItemExpirationDate> GetAllExpiryDateItems()
        {
            var final = new List<CacheItemExpirationDate>();

            var items = _expiryDateRepository.GetAll(Guid.Empty);
            final = _transferObjectMapper.MapToTransferExpiryCacheItems(items);
            return final;
        }

        public void UpdateExpiryDate(UpdateExpiryDate expiryDate)
        {
            var mapped = _accessObjectMapper.MapToAccessUpdateExpiryDate(expiryDate);
            _expiryDateRepository.UpdateExpiry(mapped);
        }
    }
}
