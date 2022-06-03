﻿using System.Threading.Tasks;

namespace Business.Adapters.SmsService
{
    public interface ISmsService
    {
        Task<bool> Send(string password, string text, string cellPhone);
        Task<bool> SendAsist(string text, string cellPhone);
    }
}
