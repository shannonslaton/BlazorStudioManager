function CreateBraintree(clientToken, FormId, submitBtn1, submitBtn2) {
    ClientToken = clientToken;

    braintree.dropin.create({
        authorization: clientToken,
        container: '#bt-dropin',
        paypal: {
            flow: 'vault'
        }
    }, function (createErr, instance) {
            $("#" + submitBtn1).click(function () {
                instance.requestPaymentMethod(function (err, payload)
                {
                    if (err) {
                        alert("Please enter your payment information.");
                        console.log('Error', err);

                        return;
                    }
                    document.querySelector('#nonce').value = payload.nonce;
                    DotNet.invokeMethodAsync("BlazorStudioManager.Client", "AssignNonce", payload.nonce);
                    $("#" + submitBtn2).click();
                });
            });
    });
}

window.BraintreeFunctions = {
    createBraintree: (clientToken, FormId, submitBtn1, submitBtn2) => { CreateBraintree(clientToken, FormId, submitBtn1, submitBtn2); }
};