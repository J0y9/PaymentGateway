using PaymentGateway.Application.Repositories;
using PaymentGateway.Domain;

namespace PaymentGateway.Application.Service;

public class PaymentService : IPaymentService
{
    private readonly RepositoryManager _repositoryManager;

    public PaymentService(RepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public void CreatePayment(Payment payment)
    {
       _repositoryManager.Payments.CreatePayment(payment);
    }
}