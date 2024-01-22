using PaymentGateway.Domain;

namespace PaymentGateway.Application.Repositories;

public interface IPaymentRepository
{
    void CreatePayment(Payment payment);

}
