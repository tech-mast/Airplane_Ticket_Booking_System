function fileChosen(element){
    const [file] = element.files;
    console.log(file);
    if (file) {
        $('#img-chosen').attr('src', URL.createObjectURL(file));
    }
}