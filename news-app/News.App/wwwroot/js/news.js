
var dataTable;

$(document).ready(function () {
    loadNewsDataTable();
});

function loadNewsDataTable() {
    dataTable = $('#DT_news').DataTable({
        "columnDefs": [
            { orderable: false, targets: -1 }
        ],
        "ajax": {
            "url": "/home/getall/",
            "type": "GET",
            "datatype": "json"
        },

        "columns": [
            { "data": "title", "width": "20%" },
            { "data": "category.name", "width": "20%" },
            
             {
                 "data": "image",
                 render: function (data) {
                     return  `<img style=" width: 50px; height: 50px;" src="${data}" />`;
                 }
             },
             
            { "data": "description", "width": "40%" },
            {
                "data": "heroImage",
                render: function (data) {
                    return `<img style=" width: 50px; height: 50px;" src="${data}" />`;
                }
            },


            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a onclick="showInPopup('/home/Form?id=${data}','Update News')" class="btn btn-sm btn-info text-white"><i class="fas fa-pencil-alt"></i></a>
                               
                                <a onclick=Delete('/home/delete?id=${data}') class="text-white btn btn-danger btn-sm text-white" style="cursor:pointer;"><i class="fas fa-trash-alt"></i></a>
                            `
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "No news found"
        },
        "width": "100%"
    })
}

function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}



showInPopup = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    })
}

jQueryAjaxPostNews = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-all-news').html(res.html);
                    loadNewsDataTable();
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');


                }
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}