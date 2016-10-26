// header icon tooltip
$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})

var UrlBuilder = {
    ImagePath: "../Content/Image/",
    ImageUrl: function (str) {
        return this.ImagePath + str;
    }
}

var imagePath = 'H:/HappyCoding/CShap/HAGWebSite/HAGWebSite/Content/Image';