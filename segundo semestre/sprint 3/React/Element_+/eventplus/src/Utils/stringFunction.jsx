/**
 * 
 * @param {*} data 
 * @returns 
 */
export const dateFormatDbToView = (data) => {
    // data 2024-11-09T00:00:00 para 09/11/2024

    data = data.substr (0,10);
    data = data.split("-");

    return `${data[2]} / ${data[1]}/ ${data[0]}`;
}

