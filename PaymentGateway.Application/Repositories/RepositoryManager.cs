using Microsoft.EntityFrameworkCore;

namespace PaymentGateway.Application.Repositories;

public class RepositoryManager
{
    private readonly DbContext _context;
    private readonly Lazy<IPaymentRepository> _payments;
    public readonly IPaymentRepository Payments;

    public RepositoryManager(DbContext context, Lazy<IPaymentRepository> payments)
    {
        _context = context;
        Payments = payments.Value;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();

    }

}