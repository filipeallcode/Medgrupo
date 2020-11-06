
$(document).ready(function () {
    $('#formAddContact').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: urlPostContact,
            method: "POST",
            data: {
                "Nome": $(this).find("#Nome").val(),
                "Nascimento": $(this).find("#Nascimento").val(),
                "Sexo": $(this).find("#Sexo").val()
            },
            error:
            function (r) {
                if (r.status == 400)
                    ModalDialog("Ocorreu um erro", r.responseJSON);
                else if (r.status == 500)
                    ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
            },
            success:
            function (r) {
                ModalDialog("Sucesso!", r)
                $("#formAddContact")[0].reset();
            }
        });
    })
    
})

function ModalDialog(titulo, texto) {
    var random = Math.random().toString().replace('.', '');
    var texto = '<div id="' + random + '" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">                                                               ' +
        '        <div class="modal-dialog">                                                                                 ' +
        '            <div class="modal-content">                                                                            ' +
        '                <div class="modal-header">                                                                         ' +
        '                    <h4 class="modal-title">' + titulo + '</h4>                                                    ' +
        '                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">                   ' +
        '                       <span aria-hidden="true">&times;</span>                                                     ' +
        '                    </button>                                                                                      ' +
        '                </div>                                                                                             ' +
        '                <div class="modal-body">                                                                           ' +
        '                    <p>' + texto + '</p>                                                                           ' +
        '                </div>                                                                                             ' +
        '                <div class="modal-footer">                                                                         ' +
        '                    <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>             ' +
        '                                                                                                                   ' +
        '                </div>                                                                                             ' +
        '            </div><!-- /.modal-content -->                                                                         ' +
        '  </div><!-- /.modal-dialog -->                                                                                    ' +
        '</div> <!-- /.modal -->                                                                                        ';

    $('body').append(texto);
    $('#' + random).modal('show');
}
