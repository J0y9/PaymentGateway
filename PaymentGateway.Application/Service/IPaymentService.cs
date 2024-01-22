using PaymentGateway.Domain;

namespace PaymentGateway.Application.Service;

public interface IPaymentService
{
    void CreatePayment(Payment payment);
}
