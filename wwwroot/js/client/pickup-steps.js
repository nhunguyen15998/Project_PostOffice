//service
function onService(){
    $('#sender-info').addClass('step-hidden')
    $('#receiver-info').addClass('step-hidden')
    $('#payment-process').addClass('step-hidden')
    $('#purchase-product').addClass('step-hidden')
    if($('#select-service').hasClass('step-hidden'))
        $('#select-service').removeClass('step-hidden')
    if($('#right-image').hasClass('step-hidden'))
        $('#right-image').removeClass('step-hidden')
    if(!$('#processing-step-1').hasClass('activated-step')){
        $('#processing-step-1').addClass('activated-step')
    }
    $('#processing-step-2').removeClass('activated-step')
    $('#processing-step-3').removeClass('activated-step')
    $('#processing-step-4').removeClass('activated-step')
    $('#processing-step-5').removeClass('activated-step')
}
$('#processing-step-1').addClass('activated-step')
onService()

//service -> product
function onProduct(){
    $('#select-service').addClass('step-hidden')
    $('#sender-info').addClass('step-hidden')
    $('#receiver-info').addClass('step-hidden')
    $('#payment-process').addClass('step-hidden')
    $('#right-image').addClass('step-hidden')
    if($('#purchase-product').hasClass('step-hidden'))
        $('#purchase-product').removeClass('step-hidden')
    if(!$('#processing-step-2').hasClass('activated-step')){
        $('#processing-step-2').addClass('activated-step')
    }
    $('#processing-step-3').removeClass('activated-step')
    $('#processing-step-4').removeClass('activated-step')
    $('#processing-step-5').removeClass('activated-step')
}
$('#btn-service-next').on('click', () => {
    onProduct()
})

//product -> sender
function onSender(){
    $('#select-service').addClass('step-hidden')
    $('#purchase-product').addClass('step-hidden')
    $('#receiver-info').addClass('step-hidden')
    $('#payment-process').addClass('step-hidden')
    if($('#sender-info').hasClass('step-hidden'))
        $('#sender-info').removeClass('step-hidden')
    if($('#right-image').hasClass('step-hidden'))
        $('#right-image').removeClass('step-hidden')
    if(!$('#processing-step-3').hasClass('activated-step')){
        $('#processing-step-3').addClass('activated-step')
    }
    $('#processing-step-4').removeClass('activated-step')
    $('#processing-step-5').removeClass('activated-step')
}
$('#btn-product-next').on('click', () => {
    onSender()
})
$('#btn-product-back').on('click', () => {
    onService()
})

//sender -> receiver
function onReceiver(){
    $('#select-service').addClass('step-hidden')
    $('#purchase-product').addClass('step-hidden')
    $('#sender-info').addClass('step-hidden')
    $('#payment-process').addClass('step-hidden')
    if($('#receiver-info').hasClass('step-hidden'))
        $('#receiver-info').removeClass('step-hidden')
    if($('#right-image').hasClass('step-hidden'))
        $('#right-image').removeClass('step-hidden')
    if(!$('#processing-step-4').hasClass('activated-step')){
        $('#processing-step-4').addClass('activated-step')
    }
    $('#processing-step-5').removeClass('activated-step')
}
$('#btn-sender-next').on('click', () => {
    onReceiver()
})
$('#btn-sender-back').on('click', () => {
    onProduct()
})

//receiver ->  payment
function onPayment(){
    $('#select-service').addClass('step-hidden')
    $('#purchase-product').addClass('step-hidden')
    $('#sender-info').addClass('step-hidden')
    $('#receiver-info').addClass('step-hidden')
    $('#right-image').addClass('step-hidden')
    if($('#payment-process').hasClass('step-hidden'))
        $('#payment-process').removeClass('step-hidden')
    $('#processing-step-5').addClass('activated-step')
}

$('#btn-receiver-next').on('click', () => {
    onPayment()
})
$('#btn-receiver-back').on('click', () => {
    onSender()
})

//payment
$('#btn-payment-back').on('click', () => {
    onReceiver()
})

//=======================service======================
//select pickup or branch
$('#pickup').prop('checked', true)
$('#at-branch').prop('checked', false)

$('#pickup').on('click', () => {
    $('#at-branch').prop('checked', false)
    if($('#pickup').is(':checked')){
        $('#sending-date-label').text("Pickup date")
    }
})

$('#at-branch').on('click', () => {
    $('#pickup').prop('checked', false)
    if($('#at-branch').is(':checked')){
        $('#sending-date-label').text("Branch arrival at")
    }
})

//=======================sender======================
$('#chb-company').prop('checked', false)
$('#company-info').addClass('step-hidden')

$('#chb-company').on('click', () => {
    if($('#chb-company').is(':checked')){
        $('#company-info').removeClass('step-hidden')
    } else {
        if(!$('#company-info').hasClass('step-hidden'))
            $('#company-info').addClass('step-hidden')
    }
})

//=======================receiver======================
let index = 1
let records = document.getElementById("add-person-info").childElementCount - 1 ?? 0
//photo
function readFile(input, index) {
    if (input.files) {
        $(`#receiver-photo-${index}`).removeClass('step-hidden')
        let count = 1
        let i = `<i class="fa-solid fa-circle-xmark"></i>`
        $(`#photo-scroll-${index}`).empty()
        Array.from(input.files).forEach(file => {
            var reader = new FileReader()
            //div
            var div = document.createElement('div')
            div.classList.add('col-sm-2', 'justify-content-center',  'p-0')  
            div.id = `div-img-${index}-`+ count
            $(`#photo-scroll-${index}`).append(div)
            //btn
            var btn = document.createElement('button')
            btn.classList.add('btn')
            btn.style.position = "absolute"
            btn.style.left = "65px"
            btn.style.top = "-5px"
            btn.id = `btn-rm-photo-${index}-` + count
            btn.addEventListener('click', () => {
                removePhoto(div.id, index)
            })
            $(`#photo-scroll-${index}`).children('#' + div.id).append(btn) 
            $(`#${btn.id}`).append(i)  
            //img
            var img = document.createElement('img')
            $(`#photo-scroll-${index}`).children('#' + div.id).append(img)
            img.width = 100
            img.height = 100
            img.id = `show-img-${index}-`+ count
            var image = document.getElementById(img.id)
            reader.onload = () => {
                image.src = reader.result
            }
            reader.readAsDataURL(file)
            count++
        })
    }
}

// Change Event to Read file content from File input
$(document).on('change', '#photos-1', function () { 
    readFile(document.getElementById('photos-1'), 1)
})
function changePhoto(index){
    readFile(document.getElementById(`photos-${index}`), index)
}

//remove photo 
$('#receiver-photo-1').addClass('step-hidden')

function removePhoto(id, index){    
    $(`#photo-scroll-${index}`).children(`#${id}`).remove()
    let input = document.getElementById(`photos-${index}`)
    let fileListArr = [...input.files]
    fileListArr.splice(id - 1, 1)
    let dataTransfer = new DataTransfer()
    for (let file of fileListArr) { 
        dataTransfer.items.add(file) 
    }
    document.getElementById(`photos-${index}`).files = dataTransfer.files
    if(!document.querySelector(`#photo-scroll-${index}`).hasChildNodes()){
        document.getElementById(`photos-${index}`).value = ""
    }
    if(document.getElementById(`photos-${index}`).files.length == 0){
        $(`#add-person-info-${index}`).children(`#receiver-photo-${index}`).addClass('step-hidden')
    }
}

function receiverInfo(index){
    return  `<div class="row">
    <div class="col-sm-12">
        <div class="row">
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap"><input
                            type="text"
                            name="receiver-first-name-${index}"
                            class="post-office-form-control post-office-text"
                            aria-invalid="false"
                            placeholder="First name">
                    </span>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap"><input
                            type="text"
                            name="receiver-last-name-${index}"
                            class="post-office-form-control post-office-text"
                            aria-invalid="false"
                            placeholder="Last name">
                    </span>
                </div>
            </div>
        </div>
    </div>
    </div>
    <div class="row">
    <div class="col-sm-12">
        <div class="row">
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap"><input
                            type="text" name="to-phone-${index}"
                            class="post-office-form-control post-office-text"
                            aria-invalid="false"
                            placeholder="Phone">
                    </span>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap"><input
                            type="text" name="to-email-${index}"
                            class="post-office-form-control post-office-text"
                            aria-invalid="false"
                            placeholder="Email">
                    </span>
                </div>
            </div>
        </div>
    </div>
    </div>
    <div class="row">
    <div class="col-sm-12">
        <div class="row">
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap"><input
                            type="text"
                            name="to-address-${index}"
                            class="post-office-form-control post-office-text"
                            aria-invalid="false"
                            placeholder="Address">
                    </span>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="input-group">
                    <span
                        class="post-office-form-control-wrap">
                        <select name="to-ward-${index}"
                            id="to-ward-${index}"
                            data-placeholder="Select ward…"
                            tabindex="-1"
                            aria-hidden="true">
                            <option value="">Select
                                ward…
                            </option>
                            <option value="EH">Western
                                Sahara
                            </option>
                            <option value="YE">Yemen
                            </option>
                            <option value="ZM">Zambia
                            </option>
                            <option value="ZW">Zimbabwe
                            </option>
                        </select>
                    </span>
                </div>
            </div>
        </div>
    </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <div class="row">
                <div class="col-sm-6">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap">
                            <select name="to-district-${index}"
                                id="to-district-${index}"
                                data-placeholder="Select district…"
                                tabindex="-1"
                                aria-hidden="true">
                                <option value="">Select
                                    district…
                                </option>
                                <option value="EH">Western
                                    Sahara
                                </option>
                                <option value="YE">Yemen
                                </option>
                                <option value="ZM">Zambia
                                </option>
                                <option value="ZW">Zimbabwe
                                </option>
                            </select>
                        </span>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap">
                            <select name="to-province-${index}"
                                id="to-province-${index}"
                                data-placeholder="Select province…"
                                tabindex="-1"
                                aria-hidden="true">
                                <option value="">Select
                                    province…
                                </option>
                                <option value="EH">Western
                                    Sahara
                                </option>
                                <option value="YE">Yemen
                                </option>
                                <option value="ZM">Zambia
                                </option>
                                <option value="ZW">Zimbabwe
                                </option>
                            </select>
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row row-btn justify-content-between" style="padding: 0 12px;">
        <div class="col-sm-2 p-0">
            <div class="input-group">
                <span class="post-office-form-control-wrap"><input
                        type="text" name="pin-code-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Pin code">
                </span>
            </div>
        </div>
        <div class="col-sm-2 p-0">
            <div class="input-group">
                <span class="post-office-form-control-wrap"><input
                        type="text" name="length-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Weight">
                </span>
            </div>
        </div>
        <div class="col-sm-2 p-0">
            <div class="input-group">
                <span
                    class="post-office-form-control-wrap"><input
                        type="text" name="length-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Length">
                </span>
            </div>
        </div>
        <div class="col-sm-2 p-0">
            <div class="input-group">
                <span
                    class="post-office-form-control-wrap"><input
                        type="text" name="width-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Width">
                </span>
            </div>
        </div>
        <div class="col-sm-2 p-0">
            <div class="input-group">
                <span
                    class="post-office-form-control-wrap"><input
                        type="text" name="height-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Height">
                </span>
            </div>
        </div>
    </div>
    <!--Parcel detail-->
    <div class="row">
        <div class="d-flex" style="padding: 0 15px;">
            <label for="pickup"
                style="font-size: 14px;"
                class="mr-2">Add parcel
                details</label>
            <div class="d-flex">
                <button type="button"
                    class="align-items-center btn d-flex justify-content-center p-0"
                    id="btn-add-more-parcel-${index}" onclick="addMoreParcel(${index})"
                    style=" border-radius: 50%; height: 20px;width: 20px;background-color: rgb(255, 205, 57);"><i
                        class="fa-solid fa-plus"
                        style="font-size: 10px;"></i></button>
            </div>
        </div>
        <div class="col-sm-12" id="parcel-detail-${index}">
            <div class="row" id="details-${index}-1">
                <div class="col-sm-7">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap"><input
                                type="text"
                                name="name-${index}-1"
                                class="post-office-form-control post-office-text"
                                aria-invalid="false"
                                placeholder="Name">
                        </span>
                    </div>
                </div>
                <div class="col-sm-2">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap"><input
                                type="text"
                                name="qty-${index}-1"
                                class="post-office-form-control post-office-text"
                                aria-invalid="false"
                                placeholder="Qty">
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--Notes-->
    <div class="row">
        <label for="notes" style="font-size: 14px;"
            class="col-sm-9">Notes</label>
        <label for="amount" style="font-size: 14px;"
            class="col-sm-3">Amount
            collected</label>
    </div>
    <div class="justify-content-between row">
        <div class="col-sm-9">
            <div class="input-group">
                <span
                    class="post-office-form-control-wrap"><textarea
                        type="text" name="notes-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Write some notes"
                        style="font-size: 12px; height: 53px;"
                        rows="1"></textarea>
                </span>
            </div>
        </div>
        <div class="col-sm-3">
            <div class="input-group">
                <span
                    class="post-office-form-control-wrap"><input
                        type="text" name="amount-${index}"
                        class="post-office-form-control post-office-text"
                        aria-invalid="false"
                        placeholder="Up to 3000k">
                </span>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="align-items-center col-sm-6 d-flex">
            <div class="input-group"
                style="margin-bottom: 0 !important;">
                <label for="pickup"
                    style="font-size: 14px;">Add some photos
                    of pickup stuff</label>
                <span class="post-office-form-control-wrap">
                    <input type="file" name="photos-${index}"
                        multiple style="font-size: 13px;"
                        id="photos-${index}" onchange="changePhoto(${index})">
                </span>
            </div>
        </div>
    </div>
    <div class="m-0 mb-5 step-hidden" id="receiver-photo-${index}" style="background-color: #ffdc39; padding: 10px; overflow: scroll hidden;">
        <div id="photo-scroll-${index}"
            class="align-items-center d-flex p-0">

        </div>
    </div>`
}
let btnBack = `<input type="button" value="BACK" id="btn-receiver-back" class="mr-3">`
let btnNext = `<input type="button" value="NEXT" id="btn-receiver-next">`
function loadBtnDelete(index){
    return `<div class="d-flex align-items-center" id="div-remove-record-${index}" 
                style="position: absolute;top: 85px;left: -55px;"></div>`
}

//btnadd
let btnAddMorePerson = document.createElement('button')
btnAddMorePerson.type = "button"
btnAddMorePerson.classList.add('align-items-center', 'btn', 'd-flex')
btnAddMorePerson.id = "btn-add-more-person"
btnAddMorePerson.style.backgroundColor = "#ffcd39"
btnAddMorePerson.style.borderRadius = "50%"
btnAddMorePerson.style.height = "45px"
let iconAdd = document.createElement('i')
iconAdd.classList.add('fa-solid', 'fa-person-circle-plus')
btnAddMorePerson.append(iconAdd)

btnAddMorePerson.addEventListener('click', () => {
    index++
    records++
    addMorePerson(`add-person-info-${index}`, index)
    if(index > 2){
        //btndelete
        let iconDelete = document.createElement('i')
        iconDelete.classList.add('fa-solid', 'fa-xmark')
        let btnRemoveRecord = document.createElement('button')
        btnRemoveRecord.type = "button"
        btnRemoveRecord.classList.add('align-items-center', 'btn', 'btn-secondary', 'd-flex', 'justify-content-center')
        btnRemoveRecord.style.borderRadius = "50%"
        btnRemoveRecord.style.width = "25px"
        btnRemoveRecord.style.height = "25px"
        btnRemoveRecord.append(iconDelete)

        let divRemove = loadBtnDelete(index)
        $(`#add-person-info-${index}`).children('.row-btn').append(divRemove)
        btnRemoveRecord.id = `btn-remove-record-${index}`
        $(`#div-remove-record-${index}`).append(btnRemoveRecord)
        btnRemoveRecord.addEventListener('click', () => {
            $(`#${btnRemoveRecord.id}`).closest('.each').remove()
            $('#div-btn-add').children('p').remove()
            let records = document.getElementById("add-person-info").childElementCount - 1
            document.getElementById('div-btn-add').insertAdjacentHTML('afterbegin', `<p class="mb-0 mr-4">Total receivers: <span>${records}</span></p>`)
        })
    }
})

$('#single-person').prop('checked', true)

$('#multiple-people').prop('checked', false)

$('#single-person').on('click', () => {
    index = 2
    $('#multiple-people').prop('checked', false)
    $('#single-person').prop('checked', true)
    if(!$('#btn-add-more-person').closest('.d-flex').hasClass('step-hidden')){
        $('#btn-add-more-person').closest('.d-flex').addClass('step-hidden')
    }
    if($('#add-person-info').find('#add-person-info-2').length){
        let index = 1
        $('#add-person-info').children('div').remove()
        loadReceiverForm(`add-person-info-${index}`, "")
        $(`#add-person-info-1`).children('hr').remove()
    }
})

$('#multiple-people').on('click', () => {
    index = 2
    $('#single-person').prop('checked', false)
    $('#multiple-people').prop('checked', true)
    if($('#btn-multiple').hasClass('step-hidden')){
        $('#btn-multiple').removeClass('step-hidden')
    }
    if($('#add-person-info').find('#add-person-info-2').length){
        $('#add-person-info').children('#add-person-info-2').remove()
    }
    addMorePerson("add-person-info-2", 2, 2)
    if($('#btn-add-more-person').hasClass('step-hidden')){
        $('#btn-add-more-person').removeClass('step-hidden')
    }
})

function loadReceiverForm(divId, index){
    var div = document.createElement('div')
    div.classList.add('each')
    div.id = divId
    div.style.position = "relative"
    $('#add-person-info').append(div)
    let receiver = receiverInfo(index)
    $(`#${divId}`).append(`<hr id="hr-${index}" style="margin-bottom: 70px;"/>`)
    $(`#${divId}`).append(receiver)
}

function addMorePerson(divId, index){
    $('#add-person-info').children('#div-btn-add').remove()
    loadReceiverForm(divId, index)
    var divBtn = document.createElement('div')
    divBtn.classList.add('d-flex', 'mb-5', 'align-items-center', 'mt-5')
    divBtn.id = "div-btn-add"
    $('#add-person-info').append(divBtn)
    let records = document.getElementById("add-person-info").childElementCount - 1
    document.getElementById('div-btn-add').insertAdjacentHTML('afterbegin', `<p class="mb-0 mr-4">Total receivers: <span>${records}</span></p>`)
    document.getElementById('div-btn-add').appendChild(btnAddMorePerson)
}

//parcel
function parcelDetail(index, count)
{
    return `<div class="row" id="details-${index}-${count}">
                <div class="col-sm-7">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap"><input
                                type="text"
                                name="name-${index}-${count}"
                                class="post-office-form-control post-office-text"
                                aria-invalid="false"
                                placeholder="Name">
                        </span>
                    </div>
                </div>
                <div class="col-sm-2">
                    <div class="input-group">
                        <span
                            class="post-office-form-control-wrap"><input
                                type="text"
                                name="qty-${index}-${count}"
                                class="post-office-form-control post-office-text"
                                aria-invalid="false"
                                placeholder="Qty">
                        </span>
                    </div>
                </div>
                <div class="col-sm-3 d-flex" style="padding-top: 10px;">
                    
                </div>
            </div>`
}

//btn-add-more-parcel-1
$('#btn-add-more-parcel-1').on('click', () => {
    loadParcelDetail(1)
})

//btn-add-more-parcel-
function addMoreParcel(index){
    loadParcelDetail(index)
}

function loadParcelDetail(index){
    let num = $(`#parcel-detail-${index}`).children('.row').length + 1
    $(`#parcel-detail-${index}`).append(parcelDetail(index, num))

    let btnRemoveParcel = document.createElement('button')
    btnRemoveParcel.classList.add('align-items-center', 'btn', 'btn-danger', 'd-flex', 'justify-content-center' ,'p-0')
    btnRemoveParcel.id = `btn-rm-parcel-${index}-${num}`
    btnRemoveParcel.style.borderRadius = "50%"
    btnRemoveParcel.style.height = "30px"
    btnRemoveParcel.style.width= "30px"
    let btnRemoveParcelIcon = document.createElement('i')
    btnRemoveParcelIcon.classList.add('fa-solid', 'fa-trash-can')
    btnRemoveParcelIcon.style.fontSize = "15px"
    btnRemoveParcel.append(btnRemoveParcelIcon)
    $(`#details-${index}-${num}`).children('.col-sm-3').append(btnRemoveParcel)
    btnRemoveParcel.addEventListener('click', () => {
        $(`#parcel-detail-${index}`).children(`#details-${index}-${num}`).remove()
    })
}

//=======================receiver======================


//AJAX
    //service
let serviceId = 0
function getServiceList(serviceId){
    $.ajax({
        url: `https://localhost:5001/Service/GetServiceList?serviceId=`+serviceId,
        type: 'get',
        dataType: 'json',
        contentType: 'application/json',
        success: function(response){
            let count  = 1
            $('#service-list').children('ul').find('div').empty()
            response.forEach(item => {
                let li = `<li style="padding: 0 20px;font-size: 14px;" id="selected-service-${count}">
                            <a role="button">${item.name}</a>
                        </li>`
                $('#service-list').children('ul').find('div').append(li)
                $(`#selected-service-${count}`).on('click', () => {
                    serviceId = item.id
                    $('#select-service').find('button').text(item.name)
                })
                count++
            })
        },
        error: function(data){
            alert(data.responseText.message)
        }
    })
}
getServiceList(0)

    //product
        //product cate
let pCateId = 0
function getProductCateList(parentId){
    $.ajax({
        url: `https://localhost:5001/Product/GetProductCategoryByParent?parentId=`+parentId,
        type: 'get',
        dataType: 'json',
        contentType: 'application/json',
        success: function(response){
            let count  = 0
            $('#product-cate-list').children('ul').find('div').empty()
            $('#product-cate-list').children('ul').find('div').append(`<li style="padding: 0 20px;font-size: 13px;" id="product-cate-${count}">
                                                                            <a role="button" onClick="getProductByPCate(0)">All</a>
                                                                        </li>`)
            response.forEach(item => {
                count++
                let li = `<li style="padding: 0 20px;font-size: 13px;" id="product-cate-${count}">
                            <a role="button">${item.name}</a>
                        </li>`
                        // <ul>
                        //         <li>
                        //             <a></a>
                        //             <ul>
                        //                 <li><a></a></li>
                        //                 <li><a></a></li>
                        //             </ul>
                        //         </li>
                        //     </ul>
                $('#product-cate-list').children('ul').find('div').append(li)
                $(`#product-cate-${count}`).on('click', () => {
                    $('#product-cate-list').find('button').text(item.name)
                    getProductByPCate(item.id)
                })
            })
        },
        error: function(data){
            alert(data.responseText.message)
        }
    })
}
getProductCateList(0)
getProductByPCate(0)
function getProductByPCate(pCateId){
    $.ajax({
        url: 'https://localhost:5001/Product/GetProductsByPCate?categoryId='+pCateId,
        type: 'get',
        dataType: 'json',
        contentType: 'application/json',
        success: function(response){
            let count = 1
            $('#product-list').children('ul').find('#div-product').empty()
            console.log(response)
            response.forEach(item=>{
                let li = `<li class="col-sm-12 mb-3">
                            <div class="align-items-center row"
                                style="line-height: 30px;">
                                <div class="col-1 d-flex justify-content-center">
                                    <img src="../../img/defaults/shop-07-1-1-768x768.jpeg"
                                        alt="" width="30" height="30">
                                </div>
                                <div class="align-items-center col-11 d-flex justify-content-between text-center">
                                    <p class="m-0 text-left" style="flex:2;">${item.name}</p>
                                    <div class="input-group" style="margin-bottom: 0 !important;width: 30%; flex:2;">
                                        <div style="border: 1px solid rgba(119, 119, 119, 0.2);">
                                            <div class="dropdown" id="product-attribute-list-${count}" style="height: 40px;">
                                                <a class="btn dropdown-toggle p-0 tg-pattribute"
                                                    href="#" role="button"
                                                    id="select-product-attribute-${count}"
                                                    data-bs-toggle="dropdown"
                                                    aria-expanded="false"
                                                    style="height: 100%; width: 100%;">
                                                    <button style="background-color: transparent;color: #111;width: 100%;text-align: left;font-size: 11px;padding: 12px 10px;"
                                                        class="btn-sm">Select product attribute</button>
                                                </a>
                                                <ul class="dropdown-menu p-0"
                                                    aria-labelledby="select-product-attribute-${count}"
                                                    style="height: 142px; width: 100%; border-radius: 0px; line-height: 40px; overflow: hidden">
                                                    <li style="padding: 0 20px;font-size: 14px;">
                                                        Select product attribute</li>
                                                    <div style="overflow: hidden scroll;height: 100px;"> </div>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p class="m-0" style="flex:1;">${item.qty} items left</p>
                                    <p class="m-0" style="flex:1;">$${item.price}</p>
                                    <button class="btn" id="btn-add-to-cart-${count}"
                                        style="background-color: #ffcd39;height: 40px;font-size: 12px;">Add
                                        to cart</button>
                                </div>
                            </div>
                        </li>`
                $('#product-list').children('ul').find('#div-product').append(li)
                count++
            })
        },
        error: function(data){
            alert(data.responseText.message)
        }
    })
}

window.addEventListener('click', function(e){   
    if (document.getElementById('product-cate-list').contains(e.target)){
        $('#product-cate-list').children('ul').css('display', 'block')
    } else{
        $('#product-cate-list').children('ul').css('display', 'none')
    }
    if (document.getElementById('product-list').contains(e.target)){
        $('#product-list').children('ul').css('display', 'block')
    } else{
        $('#product-list').children('ul').css('display', 'none')
    }
    // if (document.getElementById('product-attribute-list').contains(e.target)){
    //     $('#product-attribute-list').children('ul').css('display', 'block')
    // } else{
    //     $('#product-attribute-list').children('ul').css('display', 'none')
    // }
})