
import 'bootstrap/dist/css/bootstrap.min.css';

export const metadata = {
  title: 'BLOG DO JP'
}

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body>
      
        BLOG DO JP 
        {children}
      </body>
    </html>

    


  )
}
