<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:students="urn:students">

  <xsl:template match="/">
    <html>
      <head>
        <link rel="stylesheet" type="text/css" href="styles.css" />
      </head>
      <body>
        <table>
          <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Faculty Number</th>
            <th>Specialty</th>
            <th>Course</th>
          </tr>
          <xsl:for-each select="students:students/students:student">
            <tr>
              <td>
                <xsl:value-of select="students:name"/>
              </td>
              <td>
                <xsl:value-of select="students:sex"/>
              </td>
              <td>
                <xsl:value-of select="students:birthDate"/>
              </td>
              <td>
                <xsl:value-of select="students:facultyNumber"/>
              </td>
              <td>
                <xsl:value-of select="students:specialty"/>
              </td>
              <td>
                <xsl:value-of select="students:course"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>