import { writeFileSync } from 'fs';
import { PDFDocument } from 'pdf-lib';

(async () => {
    const pdfDoc = await PDFDocument.create();

    const page = pdfDoc.addPage();

    page.drawText('Join Data');

    const pdfBytes = await pdfDoc.save()

    writeFileSync('./test.pdf', pdfBytes);
})()