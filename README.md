To Do list

User data
({P}UserID,UserName, Password, {F}RoleID,Balance)

Role data
({P}RoleID,RoleName)

Menu data
({P}ItemsID,Name,Price,Isavailable,)

Order data
({P}OrderID,{F}UserID,OrderDate,Status)

OrderItems data
({P}OrderItemID,{F}OrderID,{F}ItemsID,Quantity)

E-walletTransactions data
({P}TransactionID,{F}UserID,Type,Amount,TransactionDate)

Feedback data
({P}FeedbackID,{F}UserID,Message,Responce,SentDate)

Refunds data
({P}RefundID,{F}OrderID,Reason,Status,RequestedDate)
