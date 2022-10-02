window.DisplayToastr = (type, message) => {
    if (type==="success") {
        toastr.success(message,"Başarılı")
    }
    if (type === "error") {
        toastr.error(message, "Hata")
    }
}