var WithdrawFactory = function ($http, $q) {
   
    return function (accountNumber, amount) {

        var deferredObject = $q.defer();

        $http.post(
            '/Withdrawal/Withdraw', {
                accNum: accountNumber,
                amount: amount
            }
        ).
        success(function (data) {
            if (data == "True") {
                deferredObject.resolve({ success: true });
            } else {
                deferredObject.resolve({ success: false });
            }
        }).
        error(function () {
            deferredObject.resolve({ success: false });
        });

        return deferredObject.promise;
    }
}

WithdrawFactory.$inject = ['$http', '$q'];