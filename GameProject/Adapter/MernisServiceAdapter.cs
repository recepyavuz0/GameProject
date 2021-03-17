using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),member.LastName.ToUpper(),member.DateOfBirth.Year
                    ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
