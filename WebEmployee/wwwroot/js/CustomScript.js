function confirmRemoval(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmRemovalSpan = 'confirmRemovalSpan_' + uniqueId;
    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmRemovalSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmRemovalSpan).hide();
    }
}