
var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "columnDefs": [
            { orderable: false, targets: -1 }
        ],
        "ajax": {
            "url": "/category/getall/",
            "type": "GET",
            "datatype": "json"
        },

        "columns": [{
            "data": "thumbnail",
            render: function (data) {
                return `<img src="${data}" width="200"  class="my-n1" alt="Avatar">`;
            }
        },
        { "data": "name", "width": "60%" },





        {
            "data": "id",
            "render": function (data) {
                return `<div class="text-center">
                                <a onclick="showInPopup('/category/Form?id=${data}','Update Category')" class="btn btn-sm btn-info text-white"><i class="fas fa-pencil-alt"></i> </a>
                               
                                <a onclick=Delete('/category/delete?id=${data}') class="text-white btn btn-danger btn-sm text-white" style="cursor:pointer;"><i class="fas fa-trash-alt"></i> </a>
                            `
            }, "width": "14%"
        }
        ],
        "language": {
            "emptyTable": "No category found"
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

jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-all').html(res.html);
                    loadDataTable();
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