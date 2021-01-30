
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

        "columns": [
            { "data": "name", "width": "40%" }, {
                "data": "status",
                render: function (data) {
                    if (data == true) {
                        return '<div style="background-color:green;color: #fff; width: 50px; text-align: center; border-radius: 4px;"> YES </div>';
                    }
                    return '<div style="background-color: red;padding: 0px 5px;color: #fff; width: 50px; text-align: center;border-radius: 4px;"  > NO </div>';
                }
            },
            
            {
                "data": "categoryImage",
                render: function (data) {
                    return  `<img style=" width: 50px; height: 50px;" src="${data}" />`;
                }
            },
            
          
           
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a onclick="showInPopup('/category/Form?id=${data}','Update Category')" class="btn btn-sm btn-info text-white"><i class="fas fa-pencil-alt"></i> Edit</a>
                               
                                <a onclick=Delete('/category/delete?id=${data}') class="text-white btn btn-danger btn-sm text-white" style="cursor:pointer;"><i class="fas fa-trash-alt"></i> Delete</a>
                            `
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
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