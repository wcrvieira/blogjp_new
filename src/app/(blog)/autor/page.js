'use server'

export async function generateMetadata({ params }) {
    return {
        title: 'Cadastro de autor'
    };
}

export default async function Page() {
    return (
        <>
            <h2>Cadastro de Autor</h2>
        </>
    )
}