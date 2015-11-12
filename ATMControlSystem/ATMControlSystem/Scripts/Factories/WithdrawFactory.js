var WithdrawFactory = function ($http, $q) {
    
    return function (accountNumber, amount) {

        var deferredObject = $q.defer();
        
        $http.post(
            '/withdrawal/withdraw', {
                accNum: accountNumber,
                amount: amount

                
            }).
        success(function (data) {
            console.log(data);
            if (data == "True") {
                deferredObject.resolve({ success: true });
                console.log("Success");
                
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