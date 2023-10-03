using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    internal interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}