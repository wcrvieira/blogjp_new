'use client';
import Link from 'next/link';
import { Navbar, Container, Nav, NavDropdown } from 'react-bootstrap'
export default function ExemploNavbar() {
    return (
        <>
            <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
                <Container>
                    <Link href="/" passHref legacyBehavior>
                        <Navbar.Brand>
                          <Link href="/blog1">Novo blog</Link>
                          
                        </Navbar.Brand>
                    </Link>
                    <Link href="/" passHref legacyBehavior>
                        <Navbar.Brand>
                            <Link href="/blog2">cadastrar usuario</Link>
                        </Navbar.Brand>
                    </Link>
                    <Link href="/" passHref legacyBehavior>
                        <Navbar.Brand>
                              <Link href="/blog3">consultar blog</Link>
                        </Navbar.Brand>
                    </Link>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                    <Navbar.Collapse id="responsive-navbar-nav">
                        <Nav className="me-auto">
                            <Link href="/" passHref legacyBehavior>
                                <Nav.Link>
                                    
                                    <Link href="/blog4">MODELO DE BLOG</Link>

                                   
                                </Nav.Link>
                            </Link>
                            <NavDropdown title="Cadastro">
                                <Link href="/" passHref legacyBehavior>
                                    <NavDropdown.Item><Link href="/blog5">Cadastrar usuário</Link></NavDropdown.Item>
                                </Link>
                                <NavDropdown.Divider />
                                <Link href="/" passHref legacyBehavior>
                                    <NavDropdown.Item><Link href="/blog6">Excluir usuário</Link></NavDropdown.Item>
                                </Link>
                                <NavDropdown.Divider />
                                <Link href="/" passHref legacyBehavior>
                                    <NavDropdown.Item><Link href="/blog7">Editar cadastro</Link></NavDropdown.Item>
                                </Link>
                                
                            </NavDropdown>
                        </Nav>
                        
                    </Navbar.Collapse>
                </Container>
            </Navbar>
           
        </>
    )
}
