namespace Wave.Schema.Enums
{
    public enum BalanceType
    {
        CREDIT, //Credit.
        DEBIT, //Debit.
        DECREASE, //Decrease using the inverse of the account's normal balance type. For contra accounts whose subtype is `DISCOUNTS` or `DEPRECIATION_AND_AMORTIZATION`, apply the amount in the account's normal balance type.
        INCREASE //Increase using the account's normal balance type. For contra accounts whose subtype is `DISCOUNTS` or `DEPRECIATION_AND_AMORTIZATION`, apply the amount in the inverse of the account's normal balance type.

    }
}
