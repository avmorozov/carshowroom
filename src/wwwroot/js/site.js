﻿// Create datagrids
$(document).ready(function () {
    var language = {
        processing: "Подождите идет загрузка...",
        search: "Поиск&nbsp;:",
        lengthMenu: "Показывать по _MENU_ записей",
        info: "Показаны записи с _START_ по _END_ из _TOTAL_ записей",
        infoEmpty: "Записей не найдено",
        infoFiltered: "(filtr&eacute; de _MAX_ &eacute;l&eacute;ments au total)",
        loadingRecords: "Chargement en cours...",
        zeroRecords: "Записей не найдено",
        emptyTable: "Записей не найдено",
        paginate: {
            first: "Первый",
            previous: "Предыдущий",
            next: "Следующий",
            last: "Последний"
        },
        aria: {
            sortAscending: ": сортировать по алфавиту",
            sortDescending: ": сортировать в обратном порядке"
        }
    }

    $('.datagrid').DataTable({ language: language, pageLength: 25, ordering: false });
    $('.datagrid-ordering').DataTable({ language: language, pageLength: 25, ordering: true });
});

