ProcessOrder();

void ProcessOrder()
{
    try
    {
        ValidateOrder();
    }
    catch (Exception ex)
    {
        throw ex;
    }
}

void ValidateOrder()
{
    throw new InvalidOperationException("Order is invalid");
}

// Questions:
// Find the issue with the exception handling in the ProcessOrder method.
// If I want to add more information to the exception (for example, I want to display the sales order number).
// But somehow I cannot change the ValidateOrder(), how can I do that?
